namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UpdateFeatureSwitchScNotify
	{
		[ProtoMember(9)] public List<FeatureSwitchInfo> SwitchInfoList;
	}
	
}
