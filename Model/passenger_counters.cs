
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
    
public partial class passenger_counters
{

    public int id { get; set; }

    public int deviceid { get; set; }

    public System.DateTime servertime { get; set; }

    public int totalPassengerIn { get; set; }

    public int totalPassengerOut { get; set; }

    public int currentPassengerIn { get; set; }

    public System.DateTime devicetime { get; set; }

    public int routeid { get; set; }



    public virtual devices devices { get; set; }

}

}
