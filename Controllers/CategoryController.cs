using Microsoft.AspNetCore.Mvc;

[Route("categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Get";
    }

    [HttpGet]
    [Route("{id:int}")]
    public string GetById(int id)
    {
        return "Get by id: " + id;
    }

    [HttpPost]
    public string Post()
    {
        return "Post";
    }

    [HttpPut]
    public string Put()
    {
        return "Put";
    }

    [HttpDelete]
    public string Delete()
    {
        return "Delete";
    }
}