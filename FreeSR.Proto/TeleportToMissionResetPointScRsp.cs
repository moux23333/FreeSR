namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TeleportToMissionResetPointScRsp
	{
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(8)] public int HHKLBCAGDIN;
		[ProtoMember(15)] public MotionInfo Motion;
	}
	
}
