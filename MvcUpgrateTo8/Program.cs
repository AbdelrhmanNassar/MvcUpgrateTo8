internal class Program
{
    private static void Main(string[] args)
    { 
        var builder = WebApplication.CreateBuilder(args);//this is whole web app
       
        #region register service
        // builder.Services.AddControllers();//Register Api services(Controller service,ModelBinding,Actions Filtration ,etc)
        builder.Services.AddControllersWithViews();//Register MVC services(Controller service,ModelBinding,Actions Filtration ,etc)
                                                   //  b
        #endregion



        var app = builder.Build(); //refer To kestral
//        app.MapGet("/", () => "Hello World!");

        //app.MapGet("/abdo", async context =>
        //{

        //    Console.WriteLine();


        //});

        app.MapControllerRoute(//just i call the name of paramter to understand
            name: "Default",
          pattern/*URL Path*/ : "{controller=Movies}/{action=Index}/{id:int?}" //defualt and constrain if i send nothing or sent only controller or action
          
          
          );

        app.Run();
    }
}