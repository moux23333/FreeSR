namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TrainVisitorBehaviorFinishScRsp
	{
		[ProtoMember(8)] public int ADELBPGJADC;
		[ProtoMember(9)] public ItemList Reward;
		[ProtoMember(6)] public int Retcode;
	}
	
}
