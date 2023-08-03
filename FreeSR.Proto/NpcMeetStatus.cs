namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NpcMeetStatus
	{
		[ProtoMember(2)] public int SeriesId;
		[ProtoMember(11)] public bool IsMeet;
	}
	
}
