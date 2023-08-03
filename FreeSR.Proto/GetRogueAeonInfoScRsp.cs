namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetRogueAeonInfoScRsp
	{
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(15)] public List<EOEIGMPKAAO> BGNMJADGHHN;
	}
	
}
