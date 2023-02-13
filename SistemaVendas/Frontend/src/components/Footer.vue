<template>
    <footer id="footer">
        <div>
            <p>Sistema Vendas</p>
        </div>
        <div>
            <p>Feito por: Matheus Balan</p>
       </div>
       <div id="linkedin">
            <p><a href="https://www.linkedin.com/in/matheus-balan-68657a247/">Linkedin</a></p>
       </div>
    </footer>
</template>

<script>
export default {
    name: 'FooterHome'
}
</script>

<style scoped>
    #footer{
        height: 200px;
        background-color: #222;
        border-top: 4px solid #111;
        color: #fff;
        display: flex;
        align-items: center;
        justify-content: center;
        width: 100%;
    }
    
</style>