//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-04-07T13:04:56+09:00
// </auto-generated>
//----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RosSharp.Message;
using RosSharp.Service;
namespace RosSharp.core
{
    public class GetLoggers : ServiceBase<GetLoggers.Request,GetLoggers.Response>
    {
        public GetLoggers()
        {
        }
        public GetLoggers(Func<Request,Response> action)
            :base(action)
        {
        }
        public override string ServiceType
        {
            get { return "core/GetLoggers"; }
        }
        public override string Md5Sum
        {
            get { return "97c560f3ceb4f0eb5828a731247d3b6f"; }
        }
        public override string ServiceDefinition
        {
            get { return "---\nstring[] loggers"; }
        }
    public class Request : IMessage
    {
        public Request()
        {
        }
        public Request(BinaryReader br)
        {
            Deserialize(br);
        }
        public string MessageType
        {
            get { return "GetLoggersRequest"; }
        }
        public string Md5Sum
        {
            get { return "d41d8cd98f00b204e9800998ecf8427e"; }
        }
        public string MessageDefinition
        {
            get { return ""; }
        }
        public void Serialize(BinaryWriter bw)
        {
        }
        public void Deserialize(BinaryReader br)
        {
        }
        public int SerializeLength
        {
            get { return 0; }
        }
        public bool Equals(Request other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return true;
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Request)) return false;
            return Equals((Request)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;

                return result;
            }
        }
    }
    public class Response : IMessage
    {
        public Response()
        {
            loggers = new List<string>();
        }
        public Response(BinaryReader br)
        {
            Deserialize(br);
        }
        public List<string> loggers { get; set; }
        public string MessageType
        {
            get { return "GetLoggersResponse"; }
        }
        public string Md5Sum
        {
            get { return "97c560f3ceb4f0eb5828a731247d3b6f"; }
        }
        public string MessageDefinition
        {
            get { return "string[] loggers"; }
        }
        public void Serialize(BinaryWriter bw)
        {
            bw.Write(loggers.Count); for(int i=0; i<loggers.Count; i++) { bw.WriteUtf8String(loggers[i]);}
        }
        public void Deserialize(BinaryReader br)
        {
            loggers = new List<string>(br.ReadInt32()); for(int i=0; i<loggers.Count; i++) { loggers[i] = br.ReadUtf8String();}
        }
        public int SerializeLength
        {
            get { return loggers.Sum(x => 4 + x.Length); }
        }
        public bool Equals(Response other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.loggers.Equals(loggers);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Response)) return false;
            return Equals((Response)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ loggers.GetHashCode();
                return result;
            }
        }
    }
    }
}