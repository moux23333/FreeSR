namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FeatureSwitchInfo
	{
		[ProtoMember(1)] public FeatureSwitchType Type;
		[ProtoMember(2)] public List<FeatureSwitchParam> SwitchList;
		[ProtoMember(3)] public bool IsAllClosed;
	}

}
