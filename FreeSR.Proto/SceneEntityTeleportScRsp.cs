namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityTeleportScRsp
	{
		[ProtoMember(5)] public int HHKLBCAGDIN;
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(6)] public EntityMotion EntityMotion;
	}
	
}
