namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FeatureSwitchParam
	{
		[ProtoMember(1)] public List<int> ParamList;
	}

}
