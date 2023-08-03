namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetQuestRecordScRsp
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(2)] public List<PHGLLNBOIMC> JLPENKAONDC;
	}
	
}
