namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AcceptMainMissionCsReq
	{
		[ProtoMember(14)] public int MainMissionId;
	}
	
}
