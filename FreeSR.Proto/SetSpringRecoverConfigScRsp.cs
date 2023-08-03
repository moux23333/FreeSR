namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetSpringRecoverConfigScRsp
	{
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(12)] public SpringRecoverConfig SpringRecoverConfig;
	}
	
}
