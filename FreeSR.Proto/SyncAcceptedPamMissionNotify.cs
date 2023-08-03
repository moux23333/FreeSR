namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncAcceptedPamMissionNotify
	{
		[ProtoMember(12)] public long NMGPIGMLAHG;
		[ProtoMember(11)] public int MainMissionId;
	}
	
}
