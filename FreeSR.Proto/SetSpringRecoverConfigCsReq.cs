namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetSpringRecoverConfigCsReq
	{
		[ProtoMember(12)] public SpringRecoverConfig SpringRecoverConfig;
	}
	
}
