namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BattleOp
	{
		[ProtoMember(1)] public int TurnCounter;
		[ProtoMember(2)] public int State;
		[ProtoMember(3)] public int ActionEntityId;
		[ProtoMember(4)] public int TargetEntityId;
		[ProtoMember(5)] public int OpType;
		[ProtoMember(6)] public int SkillIndex;
		[ProtoMember(7)] public int OperationCounter;
		[ProtoMember(8)] public string Fhpbgoggobh;
	}

}
