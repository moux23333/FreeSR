namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerReturnTakeRewardScRsp
	{
		[ProtoMember(11)] public int Retcode;
	}
	
}
