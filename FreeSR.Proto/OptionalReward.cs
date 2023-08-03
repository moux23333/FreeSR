namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class OptionalReward
	{
		[ProtoMember(8)] public int Level;
		[ProtoMember(10)] public int OptionalRewardId;
	}
	
}
