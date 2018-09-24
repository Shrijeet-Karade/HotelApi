using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfApi
{
    
    [ServiceContract]
    public interface IHotel
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/HotelDetail",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string GetRoomDetails(int HotelId);
    }
}
