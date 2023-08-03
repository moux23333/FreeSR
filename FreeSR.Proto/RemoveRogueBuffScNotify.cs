namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RemoveRogueBuffScNotify
	{
		[ProtoMember(5)] public IIEHDFBIFGP Source;
		[ProtoMember(3)] public RogueBuff MazeBuffInfo;
	}
	
}
