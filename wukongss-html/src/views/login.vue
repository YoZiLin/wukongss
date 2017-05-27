<template>
    <div>
        <hdmenu></hdmenu>
        <div class='main'>
            <div class="logo">W</div>
            <div class="title">悟空加速</div>
            <div class="descript">
                国内最好用的科学上网工具
            </div>
            <div>
                <mu-text-field label="请输入端口号" class='block' labelClass='white-word'   v-model="port" labelFloat/>
                <mu-text-field class="block" label="请输入密码" labelClass='white-word'    type='password' v-model="pwd" labelFloat/>
            </div>
            <div class="login-btn">
                <mu-raised-button label="登录" class="demo-raised-button"/>
                &nbsp;
                <mu-raised-button label="注册" class="demo-raised-button" @click='regAction();' secondary/>
            </div>
        </div>
    </div>
</template>
<script>
import hdmenu from '@/components/menu.vue'
    export default {
        name:'login',
        data () {
            return {
                port:'',
                pwd:''
            }
        },
        components:{
            hdmenu
        },
        methods:{
            regAction(){
                this.$router.push('/register');
            }
        }
    }
</script>
<style lang="scss">
    .main{
        padding-top: 50px;
        padding-bottom: 50px;
        position: absolute;
        height: 100%;
        width: 100%;

        .logo{
            margin: 0 auto;
            border-radius: 100%;
            text-align:center;
            width: 100px;
            height: 100px;
            background-color: #fff;
            line-height: 100px;
            color: #f39943;
            font-size: 50px;
        }

        .login-btn{
            text-align: center
        }

        .title{
            text-align: center;
            color:#fff;
            font-size: 25px
        }

        .descript{
            text-align: center;
            color:#fff;
            font-size: 20px;
        }

        .block{
            display: block;
            margin: 0 auto;
        }

        .white-word{
            color:#fff;
        }
    }
    .main>div{
        margin-top: 15px;
    }
</style>


