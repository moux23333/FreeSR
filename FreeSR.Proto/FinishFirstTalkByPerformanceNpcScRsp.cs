namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishFirstTalkByPerformanceNpcScRsp
	{
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(5)] public ItemList Reward;
		[ProtoMember(8)] public int KBGCLBANHMF;
	}
	
}
