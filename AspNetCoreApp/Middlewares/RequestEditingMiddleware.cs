namespace AspNetCoreApp.Middlewares
{
    public class RequestEditingMiddleware
    {
        private RequestDelegate _requestDelegate;
        public RequestEditingMiddleware(RequestDelegate requestDelegate) // ctor, otomatik constructor oluşturur.
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.ToString() == "/eren")
                await context.Response.WriteAsync("Hosgeldin Eren");
            else
                await _requestDelegate.Invoke(context); // burdaki invoke bir sonraki adrese gönderir.
        }
    }
}
