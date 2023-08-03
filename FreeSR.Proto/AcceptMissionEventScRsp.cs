namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AcceptMissionEventScRsp
	{
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(10)] public Mission MissionEvent;
	}
	
}
