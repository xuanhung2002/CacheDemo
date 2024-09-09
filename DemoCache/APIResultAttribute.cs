//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;

//namespace DemoCache
//{
//    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
//    public class APIResultAttribute : ActionFilterAttribute
//    {
//        public override void OnResultExecuting(ResultExecutingContext context)
//        {
//            if (context.Result is ObjectResult)
//            {
//                if (context.Result is OkObjectResult)
//                {
//                    context.Result = new ObjectResult(new
//                    {
//                        Code = StatusCodes.Status200OK,
//                        Data = (context.Result as ObjectResult).Value
//                    });
//                }
//                else
//                {
//                    var objR = context.Result as ObjectResult;
//                    context.Result = new ObjectResult(new
//                    {
//                        Code = objR.StatusCode.HasValue ? objR.StatusCode.Value : StatusCodes.Status200OK,
//                        Data = objR.Value
//                    });
//                }
//            }
//        }
//    }
//}
