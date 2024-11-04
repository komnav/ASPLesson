

namespace ASPLesson.Helper
{
    public class RoutHelper 
    {
        public void GetCurrentRoute(RouteData routeData)
        {
            var route = RouteResponse.Routes
                .FirstOrDefault(r => r.Action == routeData.Values["Action"]
                && r.Controller == routeData.Values["Controller"]);

            if (route == null)
            {
                var routeResponse = new RouteResponse()
                {
                    Controller = routeData.Values["controller"]?.ToString(),
                    Action = routeData.Values["action"]?.ToString(),
                };
                RouteResponse.Routes.Add(routeResponse);
            }
        }
    }
}
