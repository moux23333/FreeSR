namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetPlayerDetailInfoScRsp
	{
		[ProtoMember(12)] public HIPHMFLBDOO HDPCEBANIHK;
		[ProtoMember(11)] public int Retcode;
	}
	
}
