namespace CrowdSourcing {
    
    #line 24 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 31 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 25 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 29 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 26 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 27 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 28 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 30 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using CrowdSourcing;
    
    #line default
    #line hidden
    
    #line 1 "E:\lucas\MyDocument\VS2013\CrowdSourcingSolution\CrowdSourcing\xaml\decompose.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class decompose : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = decompose_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new decompose_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                decompose_TypedDataContext2_ForReadOnly valDataContext0 = ((decompose_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new decompose_TypedDataContext3(locations, activityContext, true);
                }
                decompose_TypedDataContext3 refDataContext1 = ((decompose_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<System.Guid>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new decompose_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                decompose_TypedDataContext3_ForReadOnly valDataContext2 = ((decompose_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new decompose_TypedDataContext3(locations, activityContext, true);
                }
                decompose_TypedDataContext3 refDataContext3 = ((decompose_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<object>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new decompose_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                decompose_TypedDataContext3_ForReadOnly valDataContext4 = ((decompose_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new decompose_TypedDataContext3(locations, activityContext, true);
                }
                decompose_TypedDataContext3 refDataContext5 = ((decompose_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<string>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new decompose_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                decompose_TypedDataContext3_ForReadOnly valDataContext6 = ((decompose_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new decompose_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                decompose_TypedDataContext3_ForReadOnly valDataContext7 = ((decompose_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new decompose_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                decompose_TypedDataContext4_ForReadOnly valDataContext8 = ((decompose_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new decompose_TypedDataContext4(locations, activityContext, true);
                }
                decompose_TypedDataContext4 refDataContext9 = ((decompose_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext9.GetLocation<object>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new decompose_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                decompose_TypedDataContext4_ForReadOnly valDataContext10 = ((decompose_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new decompose_TypedDataContext4(locations, activityContext, true);
                }
                decompose_TypedDataContext4 refDataContext11 = ((decompose_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext11.GetLocation<System.Collections.ArrayList>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new decompose_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                decompose_TypedDataContext5_ForReadOnly valDataContext12 = ((decompose_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = decompose_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new decompose_TypedDataContext5(locations, activityContext, true);
                }
                decompose_TypedDataContext5 refDataContext13 = ((decompose_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext13.GetLocation<System.Collections.ArrayList>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
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
                decompose_TypedDataContext2_ForReadOnly valDataContext0 = new decompose_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                decompose_TypedDataContext3 refDataContext1 = new decompose_TypedDataContext3(locations, true);
                return refDataContext1.GetLocation<System.Guid>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                decompose_TypedDataContext3_ForReadOnly valDataContext2 = new decompose_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                decompose_TypedDataContext3 refDataContext3 = new decompose_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<object>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                decompose_TypedDataContext3_ForReadOnly valDataContext4 = new decompose_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                decompose_TypedDataContext3 refDataContext5 = new decompose_TypedDataContext3(locations, true);
                return refDataContext5.GetLocation<string>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                decompose_TypedDataContext3_ForReadOnly valDataContext6 = new decompose_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                decompose_TypedDataContext3_ForReadOnly valDataContext7 = new decompose_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                decompose_TypedDataContext4_ForReadOnly valDataContext8 = new decompose_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                decompose_TypedDataContext4 refDataContext9 = new decompose_TypedDataContext4(locations, true);
                return refDataContext9.GetLocation<object>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                decompose_TypedDataContext4_ForReadOnly valDataContext10 = new decompose_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                decompose_TypedDataContext4 refDataContext11 = new decompose_TypedDataContext4(locations, true);
                return refDataContext11.GetLocation<System.Collections.ArrayList>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                decompose_TypedDataContext5_ForReadOnly valDataContext12 = new decompose_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                decompose_TypedDataContext5 refDataContext13 = new decompose_TypedDataContext5(locations, true);
                return refDataContext13.GetLocation<System.Collections.ArrayList>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "null") 
                        && (decompose_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "workflowId") 
                        && (decompose_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BookmarkName.WaitJudgement") 
                        && (decompose_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "simpleTask") 
                        && (decompose_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "simpleTask as string") 
                        && (decompose_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "simple") 
                        && (decompose_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "simple.Equals(\"no\")") 
                        && (decompose_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "simple.Equals(\"yes\");") 
                        && (decompose_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BookmarkName.Decomposing") 
                        && (decompose_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "returnValue") 
                        && (decompose_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "returnValue as ArrayList") 
                        && (decompose_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "arraylist_tasks") 
                        && (decompose_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "arraylist_tasks") 
                        && (decompose_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "out_arraylist_task") 
                        && (decompose_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
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
                return new decompose_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new decompose_TypedDataContext3(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new decompose_TypedDataContext3_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new decompose_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new decompose_TypedDataContext3_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new decompose_TypedDataContext3(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new decompose_TypedDataContext3_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new decompose_TypedDataContext3_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new decompose_TypedDataContext4_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new decompose_TypedDataContext4(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new decompose_TypedDataContext4_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new decompose_TypedDataContext4(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new decompose_TypedDataContext5_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new decompose_TypedDataContext5(locationReferences).@__Expr13GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class decompose_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public decompose_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class decompose_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public decompose_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class decompose_TypedDataContext1 : decompose_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.Guid parentWorkflowId;
            
            public decompose_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.ArrayList out_arraylist_task {
                get {
                    return ((System.Collections.ArrayList)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected CrowdSourcing.CrowdTask task {
                get {
                    return ((CrowdSourcing.CrowdTask)(this.GetVariableValue((1 + locationsOffset))));
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
            
            protected override void GetValueTypeValues() {
                this.parentWorkflowId = ((System.Guid)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((2 + locationsOffset), this.parentWorkflowId);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "out_arraylist_task") 
                            || (locationReferences[(offset + 0)].Type != typeof(System.Collections.ArrayList)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "task") 
                            || (locationReferences[(offset + 1)].Type != typeof(CrowdSourcing.CrowdTask)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "parentWorkflowId") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Guid)))) {
                    return false;
                }
                return decompose_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class decompose_TypedDataContext1_ForReadOnly : decompose_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.Guid parentWorkflowId;
            
            public decompose_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.ArrayList out_arraylist_task {
                get {
                    return ((System.Collections.ArrayList)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected CrowdSourcing.CrowdTask task {
                get {
                    return ((CrowdSourcing.CrowdTask)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.parentWorkflowId = ((System.Guid)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "out_arraylist_task") 
                            || (locationReferences[(offset + 0)].Type != typeof(System.Collections.ArrayList)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "task") 
                            || (locationReferences[(offset + 1)].Type != typeof(CrowdSourcing.CrowdTask)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "parentWorkflowId") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Guid)))) {
                    return false;
                }
                return decompose_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class decompose_TypedDataContext2 : decompose_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.Guid workflowId;
            
            public decompose_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected object simpleTask {
                get {
                    return ((object)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string simple {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected object returnValue {
                get {
                    return ((object)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected System.Collections.ArrayList arraylist_tasks {
                get {
                    return ((System.Collections.ArrayList)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.workflowId = ((System.Guid)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.workflowId);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 3)].Name != "simpleTask") 
                            || (locationReferences[(offset + 3)].Type != typeof(object)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "simple") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "returnValue") 
                            || (locationReferences[(offset + 6)].Type != typeof(object)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "arraylist_tasks") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.Collections.ArrayList)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "workflowId") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Guid)))) {
                    return false;
                }
                return decompose_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class decompose_TypedDataContext2_ForReadOnly : decompose_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.Guid workflowId;
            
            public decompose_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected object simpleTask {
                get {
                    return ((object)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string simple {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected object returnValue {
                get {
                    return ((object)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected System.Collections.ArrayList arraylist_tasks {
                get {
                    return ((System.Collections.ArrayList)(this.GetVariableValue((7 + locationsOffset))));
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
                
                #line 168 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ArrayList>> expression = () => 
          null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ArrayList @__Expr0Get() {
                
                #line 168 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
          null;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ArrayList ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            protected override void GetValueTypeValues() {
                this.workflowId = ((System.Guid)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 3)].Name != "simpleTask") 
                            || (locationReferences[(offset + 3)].Type != typeof(object)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "simple") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "returnValue") 
                            || (locationReferences[(offset + 6)].Type != typeof(object)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "arraylist_tasks") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.Collections.ArrayList)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "workflowId") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Guid)))) {
                    return false;
                }
                return decompose_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class decompose_TypedDataContext3 : decompose_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public decompose_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 57 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                workflowId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr1Get() {
                
                #line 57 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                workflowId;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(System.Guid value) {
                
                #line 57 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                
                workflowId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(System.Guid value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 74 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                      simpleTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr3Get() {
                
                #line 74 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                      simpleTask;
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(object value) {
                
                #line 74 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                
                      simpleTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 81 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      simple;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr5Get() {
                
                #line 81 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                      simple;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(string value) {
                
                #line 81 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                
                      simple = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                return decompose_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class decompose_TypedDataContext3_ForReadOnly : decompose_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public decompose_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 69 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      BookmarkName.WaitJudgement;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 69 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                      BookmarkName.WaitJudgement;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 86 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      simpleTask as string;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr4Get() {
                
                #line 86 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                      simpleTask as string;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 93 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              simple.Equals("no");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 93 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
              simple.Equals("no");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 152 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              simple.Equals("yes");;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr7Get() {
                
                #line 152 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
              simple.Equals("yes");;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                return decompose_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class decompose_TypedDataContext4 : decompose_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public decompose_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 109 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                              returnValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr9Get() {
                
                #line 109 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                              returnValue;
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(object value) {
                
                #line 109 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                
                              returnValue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 116 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ArrayList>> expression = () => 
                              arraylist_tasks;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ArrayList @__Expr11Get() {
                
                #line 116 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                              arraylist_tasks;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ArrayList ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(System.Collections.ArrayList value) {
                
                #line 116 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                
                              arraylist_tasks = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(System.Collections.ArrayList value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                return decompose_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class decompose_TypedDataContext4_ForReadOnly : decompose_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public decompose_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 104 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              BookmarkName.Decomposing;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr8Get() {
                
                #line 104 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                              BookmarkName.Decomposing;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 121 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ArrayList>> expression = () => 
                              returnValue as ArrayList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ArrayList @__Expr10Get() {
                
                #line 121 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                              returnValue as ArrayList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ArrayList ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                return decompose_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class decompose_TypedDataContext5 : decompose_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public decompose_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 133 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ArrayList>> expression = () => 
                                out_arraylist_task;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ArrayList @__Expr13Get() {
                
                #line 133 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                                out_arraylist_task;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ArrayList ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(System.Collections.ArrayList value) {
                
                #line 133 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                
                                out_arraylist_task = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(System.Collections.ArrayList value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                return decompose_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class decompose_TypedDataContext5_ForReadOnly : decompose_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public decompose_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public decompose_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 138 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ArrayList>> expression = () => 
                                arraylist_tasks;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ArrayList @__Expr12Get() {
                
                #line 138 "E:\LUCAS\MYDOCUMENT\VS2013\CROWDSOURCINGSOLUTION\CROWDSOURCING\XAML\DECOMPOSE.XAML"
                return 
                                arraylist_tasks;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ArrayList ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                return decompose_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
