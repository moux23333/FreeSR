namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetRecyleTimeScRsp
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(13)] public List<KEKDHAJGLOO> RogueItemList;
	}
	
}
