
public class Robot:IBeing, IRobot
{
    private string id;
    private string model;  

    public Robot(string model, string id)
    {
        Model = model;
        Id = id;       
    }

    public string Model { get; set; }
   
    public string Id { get; set; }
   
    public string ValidateId(string num, string id)
    {
        if (id.EndsWith(num))
        {
            return id;
        }

        else
        {
            return "r";
        }        
    }
}

