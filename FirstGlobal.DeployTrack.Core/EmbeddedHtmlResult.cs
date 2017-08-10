using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace FirstGlobal.DeployTrack.Core
{
    public class EmbeddedHtmlResult
    {
        //changes from reshmi
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}