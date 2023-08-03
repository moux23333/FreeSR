namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LoginActivityData
	{
		[ProtoMember(8)] public int Id;
		[ProtoMember(15)] public List<int> HasTakenLoginActivityRewardDaysList;
		[ProtoMember(7)] public int LoginDays;
	}
	
}
