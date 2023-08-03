namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetSpringRecoverDataScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(3)] public HealPoolInfo HealPoolInfo;
		[ProtoMember(9)] public SpringRecoverConfig SpringRecoverConfig;
	}
	
}
