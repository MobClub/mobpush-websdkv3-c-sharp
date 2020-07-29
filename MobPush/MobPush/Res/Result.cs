namespace MobPush.Res
{
    public class Result<T>
    {
        public const int ERROR = 500;
        public const int SUCCESS = 200;

        public int status = 200;

        public int responseCode = 200;

        public T res { get; set; }

        public string error { get; set; }

        public bool success
        {
            get { return status == 200; }
        }

        public static Result<T> newSuccess()
        {
            Result<T> res = new Result<T>();
            res.status = 200;
            return res;
        }

        public static Result<T> newSuccess(T data)
        {
            Result<T> res = new Result<T>();
            res.status = 200;
            res.res = data;
            return res;
        }

        public static Result<T> newError(int code)
        {
            Result<T> res = new Result<T>();
            res.status = code;
            res.error = "ERROR";
            return res;
        }

        public static Result<T> newError(int code, string error)
        {
            Result<T> res = new Result<T>();
            res.status = code;
            res.error = error;
            return res;
        }

        public static Result<T> newServerError(string error)
        {
            Result<T> res = new Result<T>();
            res.responseCode = 500;
            res.status = 500;
            res.error = error;
            return res;
        }
    }
}
