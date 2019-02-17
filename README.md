# NetCoreMiddleWareDemo

 private readonly RequestDelegate _next;
        private readonly UACOptions _options;


        public UACMiddleWare(RequestDelegate next, IOptions<UACOptions> options)
        {
            this._next = next;
            this._options = options.Value;
        }


        public async Task Invoke(HttpContext context)
        {
        }
