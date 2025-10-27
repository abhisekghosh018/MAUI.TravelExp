namespace TravelExp.DTOs
{
    public record CustomApiResponse(bool IsSuccess, string? Error)
    {
        public static CustomApiResponse Success() => new CustomApiResponse(true, null);
        public static CustomApiResponse Fail(string error) => new CustomApiResponse(false, error);
    }

    public record CustomApiResponse<TData>(bool IsSuccess, TData Data, string? Error)
    {
        public static CustomApiResponse<TData> Success(TData data) => new(true, data, null!);
        public static CustomApiResponse<TData> Fail(string error) => new(false, default!, error);
    }

}
