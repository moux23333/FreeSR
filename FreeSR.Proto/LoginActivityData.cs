namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LoginActivityData
	{
		[ProtoMember(1)] public int LoginDays;
		[ProtoMember(9)] public List<int> HasTakenLoginActivityRewardDaysList;
		[ProtoMember(7)] public int Id;
	}

}
