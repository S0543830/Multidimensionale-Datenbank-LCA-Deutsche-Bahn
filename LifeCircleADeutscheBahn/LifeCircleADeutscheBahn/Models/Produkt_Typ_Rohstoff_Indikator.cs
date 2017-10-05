

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web.Mvc;
using LifeCircleADeutscheBahn.Models;

namespace LifeCircleADeutscheBahn.Models
{
    public class ListProdukt
    {
        public List<Produkt_Typ_Rohstoff_Indikator> lProdukt;
    }
    public class ProduktDataList
    {
        public List<Produkt_Typ_Rohstoff_Indikator> _ListProduct { get; set; }

    }


    public class Produkt_Typ_Rohstoff_Indikator
    {
        public List<ProduktTyp> _Typ_Id { get; set; }
        public  ProduktTyp _ProduktTyp { get; set; }
        public Produkt _Produkt { get; set; }
        public List<Umweltindikatorwert> _LUmweltindikatorwert { get; set; }
        public List<Rohstoff> _LRohstoff { get; set; }
        public List<Rohstoffe> _Rohstoffe { get; set; }
        //public List<Rohstoff> _lRohstoff { get; set; }
        //public List<Umweltindikatorwert> _lUmweltindi { get; set; }
        public Rohstoff _Rohstoff { get; set; }
        public List<Umweltindikator> _LIndikator { get; set; }
        public List<MengeEinheit> _MengeEinheit { get; set; }
        public Umweltindikator _Indikator { get; set; }
        public EndOfLifeData _EndOfLifeData { get; set; }
        public Umweltindikatorwert _Umweltindikatorwert { get; set; }
        //public int _RowRohstoff { get; set; }
        //public int _RowIndikator { get; set; }
        public List<ProduktRohstoff> ProduktRohstoff { get; set; }
    }

    public class ProduktRohstoff
    {
        public Rohstoff Rohstoff { get; set; }
        public List<Umweltindikatorwert> LRohstoffe { get; set; }
    }

    public class CanvasDiagramm
    {
        public Produkt Produkt { get; set; }
        public ProduktTyp _ProduktTyp { get; set; }
        public List<CanvasDiagrammRohstoff> CanvasRohstoff { get; set; }
        public List<CanvasDiagrammIndikator> CanvasIndikator { get; set; }
    }

    public class CanvasDiagrammRohstoff
    {
        public string Name { get; set; }
        public double Wert { get; set; }
    }

    public class CanvasDiagrammIndikator
    {
        public string Name { get; set; }
        public double SummeWert { get; set; }
    }
    // Model for the diagrams
    //DataContract for Serializing Data - required to serve in JSON format
    [DataContract]
    public class DataPoint
    {
        public DataPoint(string label, int? y)
        {
            this.Y = y;
            this.Label = label;
        }

        //Explicitly setting the name to be used while serializing to JSON. 
        [DataMember(Name = "label")]
        public string Label = null;

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public Nullable<int> Y = null;

    }

    [DataContract]
    public class DataPointDec
    {
        public DataPointDec(string label, string legendText, decimal? y)
        {
            this.Y = y;
            this.Label = label;
            this.LegendText = legendText;
        }

        //Explicitly setting the name to be used while serializing to JSON. 
        [DataMember(Name = "label")]
        public string Label = null;

        //Explicitly setting the name to be used while serializing to JSON. 
        [DataMember(Name = "legendText")]
        public string LegendText = null;

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public Nullable<decimal> Y = null;

    }

    public class RohstoffIndikatorBeziehung
    {
        public int AnzahlIndikatorProRohstoff { get; set; }
    }

    public class ProduktTypViewViewModel
    {
        public ProduktTyp _ProduktTyp { get; set; }
        public string _View { get; set; }
    }

    public class IndikatorViewViewModel
    {
        public Umweltindikator _Umweltindikator { get; set; }
        public string _View { get; set; }
    }

    public class RohstoffViewViewModel
    {
        public Rohstoffe _Rohstoffe { get; set; }
        public string _View { get; set; }
    }
}

