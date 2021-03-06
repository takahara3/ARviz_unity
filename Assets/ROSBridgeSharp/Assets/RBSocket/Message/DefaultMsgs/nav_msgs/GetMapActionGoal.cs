using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class GetMapActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.nav_msgs.GetMapGoal goal;
        public override string Type() { return "nav_msgs/GetMapActionGoal"; }
        public GetMapActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.nav_msgs.GetMapGoal();
        }
    }
}