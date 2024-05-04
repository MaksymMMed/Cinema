namespace Cinema.BLL.DTOs;

public class Result<T>
{
    public bool IsSuccess { get; set; }
    public T Value { get; set; }
    public string? Error { get; set; }

    private Result(bool isSuccess, T value, string? error)
    {
        IsSuccess = isSuccess;
        Value = value;
        Error = error;
    }

    public static Result<T> Success(T value)
    {
        return new Result<T>(true, value, null);
    }

    public static Result<T?> Fail(string error)
    {
        return new Result<T?>(false, default, error);
    }
}