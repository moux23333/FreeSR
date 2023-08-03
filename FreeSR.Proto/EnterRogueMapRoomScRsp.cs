namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterRogueMapRoomScRsp
	{
		[ProtoMember(12)] public LineupInfo Lineup;
		[ProtoMember(10)] public SceneInfo Scene;
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(1)] public int CurRoomId;
	}
	
}
