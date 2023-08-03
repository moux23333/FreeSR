namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAuthkeyScRsp
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(11)] public string AuthAppid;
		[ProtoMember(12)] public int SignType;
		[ProtoMember(5)] public string Authkey;
		[ProtoMember(1)] public int AuthkeyVer;
	}
	
}
