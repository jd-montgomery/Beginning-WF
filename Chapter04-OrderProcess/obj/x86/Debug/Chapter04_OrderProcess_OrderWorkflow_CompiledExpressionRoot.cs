namespace Chapter04_OrderProcess {
    
    #line 20 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 21 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 22 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 23 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 24 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 25 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using Chapter04_OrderProcess;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\J.D\GitHub\Beginning WF\Chapter04-OrderProcess\OrderWorkflow.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class OrderWorkflow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = OrderWorkflow_TypedDataContext1_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext0 = ((OrderWorkflow_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OrderWorkflow_TypedDataContext1(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1 refDataContext1 = ((OrderWorkflow_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<decimal>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext2 = ((OrderWorkflow_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext3 = ((OrderWorkflow_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OrderWorkflow_TypedDataContext1(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1 refDataContext4 = ((OrderWorkflow_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<decimal>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext5 = ((OrderWorkflow_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext6 = ((OrderWorkflow_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OrderWorkflow_TypedDataContext1(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1 refDataContext7 = ((OrderWorkflow_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<decimal>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext8 = ((OrderWorkflow_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext9 = ((OrderWorkflow_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OrderWorkflow_TypedDataContext1(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1 refDataContext10 = ((OrderWorkflow_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext10.GetLocation<decimal>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext11 = ((OrderWorkflow_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext12 = ((OrderWorkflow_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OrderWorkflow_TypedDataContext1(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1 refDataContext13 = ((OrderWorkflow_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext13.GetLocation<decimal>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OrderWorkflow_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext14 = ((OrderWorkflow_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext14.ValueType___Expr14Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext0 = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                OrderWorkflow_TypedDataContext1 refDataContext1 = new OrderWorkflow_TypedDataContext1(locations, true);
                return refDataContext1.GetLocation<decimal>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext2 = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext3 = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                OrderWorkflow_TypedDataContext1 refDataContext4 = new OrderWorkflow_TypedDataContext1(locations, true);
                return refDataContext4.GetLocation<decimal>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext5 = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext6 = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                OrderWorkflow_TypedDataContext1 refDataContext7 = new OrderWorkflow_TypedDataContext1(locations, true);
                return refDataContext7.GetLocation<decimal>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext8 = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext9 = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                OrderWorkflow_TypedDataContext1 refDataContext10 = new OrderWorkflow_TypedDataContext1(locations, true);
                return refDataContext10.GetLocation<decimal>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext11 = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext12 = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                OrderWorkflow_TypedDataContext1 refDataContext13 = new OrderWorkflow_TypedDataContext1(locations, true);
                return refDataContext13.GetLocation<decimal>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                OrderWorkflow_TypedDataContext1_ForReadOnly valDataContext14 = new OrderWorkflow_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "0") 
                        && (OrderWorkflow_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalAmount") 
                        && (OrderWorkflow_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "OrderInfo.ShippingMethod") 
                        && (OrderWorkflow_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalAmount") 
                        && (OrderWorkflow_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalAmount") 
                        && (OrderWorkflow_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "15.0M") 
                        && (OrderWorkflow_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalAmount") 
                        && (OrderWorkflow_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalAmount") 
                        && (OrderWorkflow_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "10.0M") 
                        && (OrderWorkflow_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalAmount") 
                        && (OrderWorkflow_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalAmount") 
                        && (OrderWorkflow_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "5.0M") 
                        && (OrderWorkflow_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalAmount + (OrderInfo.TotalWeight * 0.5M)") 
                        && (OrderWorkflow_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalAmount") 
                        && (OrderWorkflow_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"The total amount is \" + TotalAmount.ToString(\"C\")") 
                        && (OrderWorkflow_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new OrderWorkflow_TypedDataContext1_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new OrderWorkflow_TypedDataContext1(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new OrderWorkflow_TypedDataContext1_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new OrderWorkflow_TypedDataContext1_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new OrderWorkflow_TypedDataContext1(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new OrderWorkflow_TypedDataContext1_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new OrderWorkflow_TypedDataContext1_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new OrderWorkflow_TypedDataContext1(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new OrderWorkflow_TypedDataContext1_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new OrderWorkflow_TypedDataContext1_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new OrderWorkflow_TypedDataContext1(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new OrderWorkflow_TypedDataContext1_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new OrderWorkflow_TypedDataContext1_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new OrderWorkflow_TypedDataContext1(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new OrderWorkflow_TypedDataContext1_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OrderWorkflow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OrderWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OrderWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OrderWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OrderWorkflow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OrderWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OrderWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OrderWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OrderWorkflow_TypedDataContext1 : OrderWorkflow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected decimal TotalAmount;
            
            public OrderWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OrderWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OrderWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Chapter04_OrderProcess.Order OrderInfo {
                get {
                    return ((Chapter04_OrderProcess.Order)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 49 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
          TotalAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr1Get() {
                
                #line 49 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
          TotalAmount;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(decimal value) {
                
                #line 49 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                
          TotalAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 93 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
            TotalAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr4Get() {
                
                #line 93 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
            TotalAmount;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(decimal value) {
                
                #line 93 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                
            TotalAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 111 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
            TotalAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr7Get() {
                
                #line 111 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
            TotalAmount;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(decimal value) {
                
                #line 111 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                
            TotalAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 69 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
              TotalAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr10Get() {
                
                #line 69 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
              TotalAmount;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(decimal value) {
                
                #line 69 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                
              TotalAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 126 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
          TotalAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr13Get() {
                
                #line 126 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
          TotalAmount;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(decimal value) {
                
                #line 126 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                
          TotalAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalAmount = ((decimal)(this.GetVariableValue((0 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.TotalAmount);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 1)].Name != "OrderInfo") 
                            || (locationReferences[(offset + 1)].Type != typeof(Chapter04_OrderProcess.Order)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "TotalAmount") 
                            || (locationReferences[(offset + 0)].Type != typeof(decimal)))) {
                    return false;
                }
                return OrderWorkflow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OrderWorkflow_TypedDataContext1_ForReadOnly : OrderWorkflow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected decimal TotalAmount;
            
            public OrderWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OrderWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OrderWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Chapter04_OrderProcess.Order OrderInfo {
                get {
                    return ((Chapter04_OrderProcess.Order)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 54 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
          0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr0Get() {
                
                #line 54 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
          0;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 82 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          OrderInfo.ShippingMethod;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 82 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
          OrderInfo.ShippingMethod;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 88 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
            TotalAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr3Get() {
                
                #line 88 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
            TotalAmount;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 98 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
            15.0M;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr5Get() {
                
                #line 98 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
            15.0M;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 106 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
            TotalAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr6Get() {
                
                #line 106 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
            TotalAmount;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 116 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
            10.0M;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr8Get() {
                
                #line 116 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
            10.0M;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 64 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
              TotalAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr9Get() {
                
                #line 64 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
              TotalAmount;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 74 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
              5.0M;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr11Get() {
                
                #line 74 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
              5.0M;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 131 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
          TotalAmount + (OrderInfo.TotalWeight * 0.5M);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr12Get() {
                
                #line 131 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
          TotalAmount + (OrderInfo.TotalWeight * 0.5M);
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 138 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
        "The total amount is " + TotalAmount.ToString("C");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 138 "C:\USERS\J.D\GITHUB\BEGINNING WF\CHAPTER04-ORDERPROCESS\ORDERWORKFLOW.XAML"
                return 
        "The total amount is " + TotalAmount.ToString("C");
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalAmount = ((decimal)(this.GetVariableValue((0 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 1)].Name != "OrderInfo") 
                            || (locationReferences[(offset + 1)].Type != typeof(Chapter04_OrderProcess.Order)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "TotalAmount") 
                            || (locationReferences[(offset + 0)].Type != typeof(decimal)))) {
                    return false;
                }
                return OrderWorkflow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
