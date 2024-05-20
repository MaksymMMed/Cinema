namespace Cinema.RecomendationSystem
{
    public class AssociativeRuleBuilder
    {
        public List<AssociativeRule> GetHighConfAssociativeRules(List<string[]> freqItemSets, List<string[]> trans, double minConfidencePct=0.75)
        {
            List<AssociativeRule> result = new List<AssociativeRule>();
            Dictionary<string[], int> itemSetCountDict = new Dictionary<string[], int>(new StringArrayComparer());

            for (int i = 0; i < freqItemSets.Count; ++i)
            {
                string[] currItemSet = freqItemSets[i]; // for clarity
                int ctItemSet = CountInTrans(currItemSet, trans, itemSetCountDict);
                for (int len = 1; len <= currItemSet.Length - 1; ++len)
                {
                    int[] c = NewCombination(len);
                    while (c != null) // each combination makes a candidate rule
                    {
                        string[] ante = MakeAntecedent(currItemSet, c);
                        string[] cons = MakeConsequent(currItemSet, c); // could defer
                        int ctAntecendent = CountInTrans(ante, trans, itemSetCountDict);
                        if (ctAntecendent != 0)
                        {
                            double confidence = (ctItemSet * 1.0) / ctAntecendent;

                            if (confidence >= minConfidencePct)
                            {
                                AssociativeRule r = new AssociativeRule(ante, cons, confidence);
                                result.Add(r);
                            }
                        }
                        c = NextCombination(c, currItemSet.Length);
                    } // while each combination
                } // len each possible antecedent for curr item-set
            } // i each freq item-set
            return result;
        }
        private int[] NewCombination(int k)
        {
            int[] result = new int[k];
            for (int i = 0; i < result.Length; ++i)
                result[i] = i;
            return result;
        }
        private int[] NextCombination(int[] comb, int n)
        {
            int[] result = new int[comb.Length];
            int k = comb.Length;
            if (comb[0] == n - k) return null;
            Array.Copy(comb, result, comb.Length);
            int i = k - 1;
            while (i > 0 && result[i] == n - k + i) --i;
            ++result[i];
            for (int j = i; j < k - 1; ++j)
                result[j + 1] = result[j] + 1;
            return result;
        }
        private string[] MakeAntecedent(string[] itemSet, int[] comb)
        {
            string[] result = new string[comb.Length];
            for (int i = 0; i < comb.Length; ++i)
            {
                int idx = comb[i];
                result[i] = itemSet[idx];
            }
            return result;
        }

        private string[] MakeConsequent(string[] itemSet, int[] comb)
        {
            string[] result = new string[itemSet.Length - comb.Length];
            int j = 0; // ptr into combination
            int p = 0; // ptr into result
            for (int i = 0; i < itemSet.Length; ++i)
            {
                if (j < comb.Length && i == comb[j])
                    ++j;
                else
                    result[p++] = itemSet[i];
            }
            return result;
        }

        private int CountInTrans(string[] itemSet, List<string[]> trans, Dictionary<string[], int> countDict)
        {
            if (countDict.ContainsKey(itemSet))
                return countDict[itemSet];

            int ct = 0;
            for (int i = 0; i < trans.Count; ++i)
            {
                if (IsSubsetOf(itemSet, trans[i]))
                    ++ct;
            }
            countDict.Add(itemSet, ct);
            return ct;
        }

        private class StringArrayComparer : IEqualityComparer<string[]>
        {
            public bool Equals(string[] x, string[] y)
            {
                if (x == null || y == null) return x == y;
                return x.SequenceEqual(y);
            }

            public int GetHashCode(string[] obj)
            {
                if (obj == null) return 0;
                int hash = 17;
                foreach (string str in obj)
                {
                    hash = hash * 23 + (str?.GetHashCode() ?? 0);
                }
                return hash;
            }
        }

        private bool IsSubsetOf(string[] itemSet, string[] trans)
        {
            int foundIdx = -1;
            for (int j = 0; j < itemSet.Length; ++j)
            {
                foundIdx = IndexOf(trans, itemSet[j], foundIdx + 1);
                if (foundIdx == -1) return false;
            }
            return true;
        }

        private int IndexOf(string[] array, string item, int startIdx)
        {
            for (int i = startIdx; i < array.Length; ++i)
            {
                if (string.Compare(array[i], item) > 0) return -1;
                if (array[i] == item) return i;
            }
            return -1;
        }

    }
}