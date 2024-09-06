using Microsoft.AspNetCore.Mvc;

namespace MvcUpgrateTo8.Controllers
{
    public class MoviesController : Controller

    {
        private IConfiguration _configuration;
        public MoviesController(IConfiguration configuration)//ask Clr for CREATING  object from class implement IConfiguration To use app setting
        {
            _configuration = configuration;
        }


        //Action :public not static object member method inside the controller


        //baseUrl/Movies/GetMoive
        public string GetMovie(int id)
        {
            return $"MoiveId:{id}";
        }

        [ActionName("GetAllMovies")]
        public string GeMovies()
        {
            return $"";
        }   
        //public string GetMovie(int id,int Q)
        //{
        //    return $"MoiveId:{id}";
        //} 
      
    }
}
