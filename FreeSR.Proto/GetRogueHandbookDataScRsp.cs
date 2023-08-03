namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetRogueHandbookDataScRsp
	{
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(5)] public NMGHEEPMBAD HandbookInfo;
	}
	
}
