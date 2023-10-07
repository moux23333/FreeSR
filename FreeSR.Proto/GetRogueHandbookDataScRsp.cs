namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetRogueHandbookDataScRsp
	{
		[ProtoMember(2)] public GLJKEAEGKJG HandbookInfo;
		[ProtoMember(5)] public int Retcode;
	}

}
