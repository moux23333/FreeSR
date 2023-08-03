namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetUnlockTeleportScRsp
	{
		[ProtoMember(9)] public List<int> EMGKEPONFBH;
		[ProtoMember(12)] public int Retcode;
	}
	
}
