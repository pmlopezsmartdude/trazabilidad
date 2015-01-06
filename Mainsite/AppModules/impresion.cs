using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Sockets;
using System.Web.Security;
using System.Security.Cryptography;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Mainsite.AppModules
{
    public class impresion
    {
        public static string imprimebixolon(string ip, int puerto, string fruit, string fruto, string variedad, string calibre, string dark, string cat, string peso, string codigoenvase, string lote, string numproceso, string fechaembalaje, string sdp, string codigoproductor, string region, string provincia, string comuna, string cse, string exportador, string csp, string packing, string salida, string turnos, string codigobarras)
        {
            try
            {
                IPHostEntry IPHost = Dns.GetHostEntry(ip);
                string[] aliases = IPHost.Aliases;
                IPAddress[] addr = IPHost.AddressList;
                EndPoint ep = new IPEndPoint(addr[0], puerto);
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.Connect(ep);
                NetworkStream ns = new NetworkStream(sock);
                string impresionslcs = "^CB" + "^SM0,0" + "^SS3" + "^SW530" + "^STd" + "^SOT" + "^SD20" + "^SL400,28,G" + "^T53,15,2,0,1,0,0,N,B,'" + fruit + "/" + fruto +
                    "'" + "^T53,45,2,0,2,0,0,N,B,'" + variedad + "'" + "^T317,18,4,2,2,0,0," + dark + ",N,'" + calibre + "'" + "^T310,100,2,2,1,0,0,N,N,'" + cat + "'" +
                    "^T53,92,1,0,0,0,0,N,N,'Net Wt: Kg. Neto'" + "^T53,105,2,1,2,0,0,N,N,'^" + peso + "'" + "^T160,105,2,1,2,0,0,N,B,'" + codigoenvase + "'" +
                    "^T311,127,1,0,0,0,0,N,N,'" + lote + "'" + "^T311,147,1,0,0,0,0,N,N,'Prc.No:" + numproceso + "'" + "^T311,167,1,0,0,0,0,N,N,'Date/Fecha:'" +
                    "^T311,184,1,0,2,0,0,N,N,'" + fechaembalaje + "'" + "^T311,230,1,0,2,0,0,N,N,'SDP:" + sdp + "'" + "^BD309,14,470,232,B,2" + "^T53,153,0,0,2,0,0,N,B,'Grower/Productor/CSG:'" +
                    "^T205,176,2,1,2,0,0,N,B,'" + codigoproductor + "'" + "^T53,194,1,0,0,0,0,N,N,'REGION: '" + "^T144,194,1,0,0,0,0,N,N,'" + region + "'" +
                    "^T53,224,1,0,0,0,0,N,N,'PROV:'" + "^T112,218,0,0,2,0,0,N,N,'" + provincia + "'" + "^T53,255,1,0,0,0,0,N,N,'COM:'" + "^T112,249,0,0,2,0,0,N,N,'" +
                    comuna + "'" + "^T472,395,0,0,0,0,3,N,N,'PRODUCE OF CHILE/PRODUCTO'" + "^T472,168,0,0,0,0,3,N,N,'DE'" + "^T472,148,0,0,0,0,3,N,N,'CHILE'" +
                    "^T472,98,0,0,0,0,3,N,N,'CSE:" + cse + "'" + "^T485,395,0,0,0,0,3,N,B,F,'Export by:" + exportador + "'" + "^T22,370,0,0,0,0,3,N,N,F,'Packing by/Embalado por/CSP: " + csp + "'" +
                    "^T37,370,0,1,1,0,3,N,N,'" + packing + "'" + "^T53,390,2,1,1,0,3,N,N,'" + salida + "'" + "^T446,380,2,1,1,0,3,N,N,'" + turnos + "'" + "^B190,305,1,3,300,100,0,0,'" + codigobarras + "'" +
                    "^T130,280,2,1,1,0,0,N,N,'(21)" + codigobarras + "'" + "^P1";
                byte[] toSend = Encoding.ASCII.GetBytes(impresionslcs);
                ns.Write(toSend, 0, toSend.Length);
            }
            catch (SystemException ex)
            {
                
                string error = "error:" + ex + "de impresion";
                return error;
            }
            finally
            {
               
            }
            return "0";

        }
    }
}