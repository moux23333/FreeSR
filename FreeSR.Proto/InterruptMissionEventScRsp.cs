namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class InterruptMissionEventScRsp
	{
		[ProtoMember(5)] public int MissionEventId;
		[ProtoMember(14)] public int Retcode;
	}
	
}
