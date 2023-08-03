namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAuthkeyCsReq
	{
		[ProtoMember(13)] public string AuthAppid;
		[ProtoMember(11)] public int AuthkeyVer;
		[ProtoMember(8)] public int SignType;
	}
	
}
