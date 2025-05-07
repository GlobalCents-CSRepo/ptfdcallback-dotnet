using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PTFDCallbackModel;

public class Dummy
{
    [JsonProperty("request", NullValueHandling = NullValueHandling.Ignore)]
    public CallbackRequest request{ get; set; }
    
    [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
    public CallbackResponse response{ get; set; }
}

public enum Status
{
    Ok = 0,
    Error = 1,
    Unchanged = 2
}

[DisplayName("Callback request")]
[Description("Provides context about the client or source system requesting the operation.")]
public class CallbackRequest
{
    [JsonProperty("dataid", NullValueHandling = NullValueHandling.Ignore)]
    [Description("The DataID of the document.")]
    public string dataid{ get; set; }

    [JsonProperty("builderid", NullValueHandling = NullValueHandling.Ignore)]
    [Description("The DataID of the builder.")]
    public string builderid{ get; set; }
    
    [JsonProperty("cacheid", NullValueHandling = NullValueHandling.Ignore)]
    [Description("The ticket ID.")]
    public string cacheid{ get; set; }

    [JsonProperty("documentpath", NullValueHandling = NullValueHandling.Ignore)]
    [Description("The file path to the document")]
    public string documentpath{ get; set; }
    
    [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
    [Description("The metadata associated to the document")]
    public object metadata{ get; set; }

}


[DisplayName("Callback response")]
[Description("Provides the response to the PTFD callback request.")]
public class CallbackResponse
{
    [JsonProperty("dataid", NullValueHandling = NullValueHandling.Ignore)]
    [Description("The DataID of the document.")]
    public string dataid{ get; set; }

    
    [JsonProperty("cacheid", NullValueHandling = NullValueHandling.Ignore)]
    [Description("The ticket ID.")]
    public string cacheid{ get; set; }

    [JsonProperty("documentpath", NullValueHandling = NullValueHandling.Ignore)]
    [Description("the file path to the document")]
    public string documentpath{ get; set; }
    
    [EnumDataType(typeof(Status))]
    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public string status { get; set; }

    [JsonProperty("statusmsg", NullValueHandling = NullValueHandling.Ignore)]
    public string statusmsg { get; set; }

}