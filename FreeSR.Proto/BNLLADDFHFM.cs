namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BNLLADDFHFM
	{
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(4)] public long EndTime;
	}

}
