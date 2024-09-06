using Microsoft.AspNetCore.Mvc;

namespace MvcUpgrateTo8.Controllers
{
    public class MoviesController : Controller

    {
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
