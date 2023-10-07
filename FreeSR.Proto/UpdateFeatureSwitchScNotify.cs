namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UpdateFeatureSwitchScNotify
	{
		[ProtoMember(10)] public List<FeatureSwitchInfo> SwitchInfoList;
	}

}
