using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstGlobal.DeployTrack.Models
{
    public class DeployTrackViewModel
    {
        //public int Id { get; set; }

        //[Display(Name = "Module Name")]
        //[DisplayColumn("ModuleName")]
        public string ModuleName { get; set; }
    }
}