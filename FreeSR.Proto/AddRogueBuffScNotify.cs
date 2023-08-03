namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AddRogueBuffScNotify
	{
		[ProtoMember(3)] public IIEHDFBIFGP Source;
		[ProtoMember(9)] public RogueBuff MazeBuffInfo;
	}
	
}
