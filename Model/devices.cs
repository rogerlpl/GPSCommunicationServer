
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace GPSCommunicationServer.Model
{

using System;
    using System.Collections.Generic;
    
public partial class devices
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public devices()
    {

        this.positions = new HashSet<positions>();

        this.passenger_counters = new HashSet<passenger_counters>();

    }


    public int id { get; set; }

    public string name { get; set; }

    public string uniqueid { get; set; }

    public Nullable<System.DateTime> lastupdate { get; set; }

    public Nullable<int> positionid { get; set; }

    public Nullable<int> groupid { get; set; }

    public string attributes { get; set; }

    public string phone { get; set; }

    public string model { get; set; }

    public string contact { get; set; }

    public string category { get; set; }

    public Nullable<int> routeId { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<positions> positions { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<passenger_counters> passenger_counters { get; set; }

}

}
